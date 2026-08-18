# PlexNaming

**PlexNaming** is a Windows Forms utility for quickly generating consistently formatted TV episode names for Plex.
It supports both **manual episode naming** and **automatic batch renaming using episode information from TheTVDB**.

## Features

### Manual Naming

* Enter a show, season, episode, and episode name
* Automatically formats season and episode numbers
* Copies the generated filename directly to the clipboard
* Automatically increments the episode number after generating a name
* Increment the season and reset the episode to `1`
* Episode names are optional

### Automatic Renaming

* Enter a **TheTVDB season URL**
* Select a folder containing the season's video files
* Automatically retrieves episode names and numbers from TheTVDB
* Matches the files to episodes based on their sorted filename order
* Generates Plex-compatible filenames automatically
* Preserves the original file extension
* Removes characters that are invalid in Windows filenames

## Output Format

PlexNaming uses the following filename format:

```text
Show Name - season 01 - s01e02 - Episode Name
```

If no episode name is provided, the format is:

```text
Show Name - season 01 - s01e02
```

## Manual Naming

The manual naming form is useful when you want to generate a filename for an individual episode.

1. Enter the **show name**.
2. Enter the **season number**.
3. Enter the **episode number**.
4. Optionally enter the **episode name**.
5. Click **Get Name**.
6. The formatted name is displayed and copied to the clipboard.
7. The episode number is automatically incremented for the next episode.

Use **Increment Season** to move to the next season. This increments the season number and resets the episode number to `1`.

### Example

Entering:

```text
Show:    The Example Show
Season:  1
Episode: 2
Name:    The Second Episode
```

produces:

```text
The Example Show - season 01 - s01e02 - The Second Episode
```

The generated name is also copied to the clipboard.

## Automatic Renaming

The automatic renaming feature can rename an entire season using episode information from TheTVDB.

### 1. Enter the TVDB Season URL

Paste the URL for the relevant season from TheTVDB.

For example:

```text
https://thetvdb.com/series/example-show/seasons/official/1
```

PlexNaming uses the season URL to determine:

* Show name
* Season number
* Episode numbers
* Episode names

### 2. Select the Season Folder

Enter the path to the folder containing the video files for that season.

PlexNaming currently detects the following video formats:

* `.mkv`
* `.mp4`
* `.avi`
* `.m4v`
* `.mov`
* `.wmv`
* `.ts`
* `.webm`

Files are sorted alphabetically by filename before being matched to the episodes retrieved from TheTVDB.

### 3. Check Results

Click **Check Results** to retrieve the episode information and generate a preview of the proposed changes.

The preview shows the original filename and the new filename:

```text
Episode01.mkv    ->  The Example Show - season 01 - s01e01 - Pilot.mkv
Episode02.mkv    ->  The Example Show - season 01 - s01e02 - The Second Episode.mkv
Episode03.mkv    ->  The Example Show - season 01 - s01e03 - Another Episode.mkv
```

No files are renamed during this step.

### 4. Apply Results

Once the preview has been checked, click **Apply Results**.

PlexNaming asks for confirmation before making any changes.

Before renaming, it verifies that:

* Every source file still exists
* None of the destination filenames already exists

If all checks pass, the files are renamed.

## Important: File Ordering

Automatic renaming matches video files to TVDB episodes based on **alphabetical filename order**.

For example, if the folder contains:

```text
Episode 01.mkv
Episode 02.mkv
Episode 03.mkv
```

they will be matched to:

```text
S01E01
S01E02
S01E03
```

Make sure the files are named or ordered correctly before applying the changes.

## Filename Sanitisation

Windows does not allow certain characters in filenames.

PlexNaming automatically removes invalid filename characters from generated filenames before attempting to rename the files.

The original file extension is preserved.

For example:

```text
The Example Show - season 01 - s01e01 - Episode: One?.mkv
```

may become:

```text
The Example Show - season 01 - s01e01 - Episode One.mkv
```

## Requirements

* Windows
* C#
* .NET
* Windows Forms
* Internet connection for automatic TVDB lookups

## Dependencies

The automatic renaming functionality uses:

* [HtmlAgilityPack](https://www.nuget.org/packages/HtmlAgilityPack/) — used to parse the HTML returned by TheTVDB.