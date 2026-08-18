# PlexNaming

A simple Windows Forms utility for quickly generating consistently formatted TV episode names for Plex.

## Features

- Enter a show, season, episode, and episode name
- Automatically formats season and episode numbers with leading zeros
- Copies the generated filename directly to the clipboard
- Automatically increments the episode number after generating a name
- Quickly increment the season and reset the episode to `1`
- Episode names are optional

## Output Format

With an episode name:

```text
Show Name - season 01 - s01e02 - Episode Name
```

Without an episode name:

```text
Show Name - season 01 - s01e02
```

## Usage

1. Enter the **show name**.
2. Enter the **season number**.
3. Enter the **episode number**.
4. Optionally enter the **episode name**.
5. Click **Get Name** to generate and copy the formatted name.
6. The episode number is automatically incremented for the next episode.

Use the **Increment Season** button to move to the next season and reset the episode number to `1`.

## Requirements

- C#
- .NET / Windows Forms
- Windows
