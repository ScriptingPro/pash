# This flat string is easy to interpret and sorts the same
# alphabetically and chronologically
function Convert-FBTimeToFlatString
{
    Param([DateTime][Parameter(Mandatory=$true,Position=0)]$dateTime)

    Set-StrictMode -Version 2.0
    trap { "Error in Convert-FBTimeToFlatString: $_"; break }

    $dateTime.ToString("yyyy-MM-dd-HH-mm-ss")
}

# Keep chronologically-named record of your friends list,
# so that you can monitor changes. CSV format is good for Excel,
# automated monitoring via PowerShell would be easier with Export-CliXml.
function Backup-FBFriends
{
    Set-StrictMode -Version 2.0
    trap { "Error in Backup-FBFriends: $_"; break }

    $timeString = Convert-FBTimeToFlatString $(get-date)
    $filename = "c:\temp\friends.$timeString.csv"
    write-verbose "Backing up friends list to $filename"
    $friends = Get-FBFriends
    $userdata = $friends | Get-FBObjectData
    $userdata | Export-Csv $filename
}

# Retrieve events owned by a specific owner, for example a group
# Filter to those starting between 24 hours ago and 1 week from now
# Backup RSVP lists to CSV files
function Write-FBRSVPs
{
    Param(
        [string][Parameter(Mandatory=$true,Position=0)]$OwnerId,
        [string]$BasePath = "c:\temp",
        [DateTime]$After,
        [DateTime]$Before
    )

    $events = @(Get-FBEvents -Fields id,owner,name,start_time,attending,maybe,declined,noreply)
    Write-Debug "$($events.Count) total events"
    
    $events2 = @($events | where {$_.owner.id -eq $OwnerId})
    Write-Debug "$($events2.Count) events owned by $OwnerId"
    
    if ($After)
    {
        $events3 = @($events2 | where {([DateTime]$_.start_time) -ge $After})
        Write-Debug "$($events3.Count) events start after $After"
    }
    else
    {
        $events3 = $events2
    }
    
    if ($Before)
    {
        $events4 = @($events3 | where {([DateTime]$_.start_time) -le $Before})
        Write-Debug "$($events4.Count) events start before $Before"
    }
    else
    {
        $events4 = $events3
    }
    
    foreach ($event in $events4)
    {
        $timeString = Convert-FBTimeToFlatString $event.start_time
        $filename = join-path $BasePath "event.$($event.name).$(Convert-FBTimeToFlatString $event.start_time).csv"
        $attendees = @()
        if ($event.attending)
        {
            $attendees += $event.attending
        }
        if ($event.maybe)
        {
            $attendees += $event.maybe
        }
        if ($event.noreply)
        {
            $attendees += $event.noreply
        }
        if ($event.declined)
        {
            $attendees += $event.declined
        }
        Write-Verbose "Writing $($attendees.Count) RSVPs for event $fileName"
        if (0 -eq $attendees.Count)
        {
            Write-Warning "No attendees for event $($event.id) $($event.name): Be sure to query fields attending, maybe, noreply, and/or declined"
        }
        $attendees | Export-Csv $filename
    }
}

# Retrieve events from the feed for a specific owner,
# for example a user or group.
# Note that this script must query each event separately.
function Get-FBEventsFromFeed
{
    Param(
        [string][Parameter(Mandatory=$true,Position=0)]$Id = "me",
        [string[]]$Fields
    )
    
    $feed = Get-FBFeed -Id $Id
    $header = "http://www.facebook.com/event.php?eid="
    $feedEvents = $feed | where {$_.link.StartsWith($header)}
    foreach ($feedEvent in $feedEvents)
    {
        $eventId = $feedEvent.link.Substring($header.Length)
        $eventData = Get-FBObjectData $eventId -Fields $Fields
        $eventData
    }
}

# Filter events to those starting after $Before or ending before $After
function Find-FBEventsByTime
{
    Param(
        [object][Parameter(ValueFromPipeline=$true, Position=0)]$event,
        [DateTime]$After,
        [DateTime]$Before
    )
    Process
    {
        if ($After)
        {
            if ([DateTime]$event.end_time -lt $After)
            {
                return
            }
        }
    
        if ($Before)
        {
            if ([DateTime]$event.start_time -gt $Before)
            {
                return
            }
        }
        $event
    }
}

# Write event attendees to CSV
# Requires that fields be specifically requested:
#   attending, maybe, noreply, and/or declined
function Write-EventAttendeeCsv
{
    Param(
        [object][Parameter(ValueFromPipeline=$true, Position=0)]$event,
        [string]$BasePath = "c:\temp"
    )
    Process
    {
        $timeString = Convert-FBTimeToFlatString $event.start_time
        $filename = join-path $BasePath "event.$($event.name).$(Convert-FBTimeToFlatString $event.start_time).csv"
        $attendees = @()
        if ($event.attending)
        {
            $attendees += $event.attending
        }
        if ($event.maybe)
        {
            $attendees += $event.maybe
        }
        if ($event.noreply)
        {
            $attendees += $event.noreply
        }
        if ($event.declined)
        {
            $attendees += $event.declined
        }
        Write-Verbose "Writing $($attendees.Count) RSVPs for event $fileName"
        if (0 -eq $attendees.Count)
        {
            Write-Warning "No attendees for event $($event.id) $($event.name): Be sure to query fields attending, maybe, noreply, and/or declined"
        }
        $attendees | Export-Csv $filename
    }
}

<#
This example script brings together several of the pieces above.
It retrieves the events from the feed of the group specified,
filters to those between yesterday and one week in the future,
and writes the attendee lists to individual CSV files for each event.
This is a key scenario for my lead customer -- it enables them
to bring a signup sheet of expected attendees to each event.
$groupId = "..."
$now = [DateTime]::Now
$yesterday = $now - [Timespan]::FromDays(1)
$oneWeek = $now + [Timespan]::FromDays(7)
$feedEvents = Get-FBEventsFromFeed $groupId -Fields id,owner,name,start_time,end_time,attending,maybe,declined,noreply
$events = $feedEvents | Find-FBEventsByTime -After $yesterday -Before $oneWeek
$events | Write-EventAttendeeCsv
#>
