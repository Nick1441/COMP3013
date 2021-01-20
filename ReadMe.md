# COMP3013 Project - Roll Initiative
The Repo Readme for Team Roll Initiative
This repo will contain the project files for our procedurally generated bullet hell shooter

Name|ID|Email|Roles|
---|---|---|---
Zack Hawkins|`10587295`|zachary.hawkins@students.plymouth.ac.uk|**Product Owner**, Product lead
Matt Hough|`10616194`|matthew.hough@students.plymouth.ac.uk|**Scrum Master**, Product organiser
Nick Clothier|`10607665`|nicholas.clothier@students.plymouth.ac.uk|**Tech Lead**, Product manager

# Project Layout
This project will be a procedurally generated bullet hell style of game. It will generate a terrain for the combat to take place, then it will place cover for the player to use. Health packs so they can get their healt back. Finally it will generate enemies. This will all make use of Perlin noise, a pseudo-random computer generated noise.

# Technology Used
- Throughout this project We will be primarily using [Unity](https://unity.com/) as the main software for the development of my project.
- We will also be using [Microsoft Planner](https://tasks.office.com/) to aid with the agile development.
- To communicate with team members we will be using Disord (A group chat software) as well as [Zoom](https://zoom.us/). This is replacing the normal contact time we would have been able to do if it weren't for COVID-19.

# Links to videos



![Main Menu](https://img.itch.zone/aW1hZ2UvODg4MzY5LzUwMTI4OTEucG5n/347x500/SiIetD.png)
![Screenshot of gameplay 1](https://img.itch.zone/aW1hZ2UvODg4MzY5LzUwMTI4OTAucG5n/347x500/LyOgDm.png)
![Screenshot of gameplay 2](https://img.itch.zone/aW1hZ2UvODg4MzY5LzUwMTI4OTUucG5n/347x500/8YDp0E.png)
![Screenshot of gameplay 3](https://img.itch.zone/aW1hZ2UvODg4MzY5LzUwMTI4OTYucG5n/347x500/P1R7OM.png)

# Team meeting schedules
Due|Action|By
---|---|---
Thursday Afternoon (2pm start) | **Sprint review**: Discuss how the week's sprint went, and decide on tasks for the following weeks' sprint.|Everyone
Any other meeting | **Coding help**: Meeting using discord to help each other with issues that arise throughout development |Anyone


# Code base structure
We will be following Microsoft's .NET framework [coding conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions).

- **Comments**: 
Comments will be present throughout scripts, especially before a method detailing what that method does (and if so, what value it returns). Place the comment on a separate line, not at the end of a line of code. Comments must follow standardised English with appropriate punctuation.Insert one space between the comment delimiter (//) and the comment text. 

```
  // This is a proper comment. It does
  
  // not violate any rules.
  ```
  
- **Code**: Lines must be <75 characters in length. Write only one statement per line. Write only one declaration per line. If continuation lines are not indented automatically, indent them one tab stop (four spaces). Add at least one blank line between method definitions and property definitions
- **Peer review**: Individual scripts should be checked for these standards before being merged into the master branch.

# .gitignore fixing
Sometimes the .gitignore isn't followed properly, especially across different clients. If you end up committing your Library directory or anything else that violates the .gitignore, you can run these commands in the root of the git folder to clean it up.

- First, commit anything that you've done.
- `git rm -r --cached .` (removes everything cached from the git)
- `git add .` (re-adds everything, passing it through the .gitignore)

# User Story

![Userstory](https://i.gyazo.com/61f29b4693b0efd8bc646e2d6f68c4bf.png)

# Roadmap

![Roadmap](https://i.gyazo.com/b0c634a0713bdfd4c357b1a14ed4d22e.png)

# Setup Guide
Head to the itch.io page linked below and follow the instructions there

[**Roll Initiative Itch page**](https://nick1441.itch.io/neon-nights?secret=znFS5NB5To9hjD6NtSZGyrDk7s)
