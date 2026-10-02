# PlexNaming

**PlexNaming** is a Windows Forms app that makes it easy to create Plex-friendly TV episode filenames.

It has two ways to name episodes:

* **Manual Naming** — create a filename one episode at a time.
* **Automatic Renaming** — rename an entire season using episode information from TheTVDB.

## Features

### Manual Naming

Enter:

* Show name
* Season number
* Episode number
* Episode name (optional)

PlexNaming will create a filename such as:

```text
The Example Show - season 01 - s01e02 - The Second Episode
```

The generated name is automatically copied to your clipboard, and the episode number is increased for the next episode.

You can also use **Increment Season** to move to the next season and reset the episode number to `1`.

### Automatic Renaming

Automatic mode can rename an entire season using information from a **TheTVDB season page**.

1. Enter the TheTVDB season URL.
2. Select the folder containing the season's video files.
3. Click **Check Results**.
4. Review the proposed filenames.
5. Click **Apply Results** to rename the files.

For example:

```text
Episode01.mkv
Episode02.mkv
Episode03.mkv
```

can become:

```text
The Example Show - season 01 - s01e01 - Pilot.mkv
The Example Show - season 01 - s01e02 - The Second Episode.mkv
The Example Show - season 01 - s01e03 - Another Episode.mkv
```

The original file extension is preserved.

## Important: File Order

Automatic renaming matches files to episodes based on their **filename order**.

For example:

```text
Episode01.mkv  ->  S01E01
Episode02.mkv  ->  S01E02
Episode03.mkv  ->  S01E03
```

Make sure your files are in the correct order before applying the changes.

PlexNaming will **not rename files when you click Check Results**. You can review the changes first and only rename them when you click **Apply Results**.

## Supported Video Files

PlexNaming currently detects:

```text
.mkv
.mp4
.avi
.m4v
.mov
.wmv
.ts
.webm
```

## Filename Format

PlexNaming uses:

```text
Show Name - season 01 - s01e02 - Episode Name
```

If there is no episode name:

```text
Show Name - season 01 - s01e02
```

Invalid Windows filename characters are automatically removed.

The original file extension is kept.

## Requirements

* Windows
* .NET / C#
* Internet connection for automatic TheTVDB lookups

## Dependency

Automatic renaming uses **HtmlAgilityPack** to read episode information from TheTVDB.

* [HtmlAgilityPack](https://www.nuget.org/packages/HtmlAgilityPack/)

## Notes

Automatic renaming checks that:

* The number of video files matches the number of episodes.
* All source files still exist.
* None of the new filenames already exist.

No files are changed until **Apply Results** is confirmed.
