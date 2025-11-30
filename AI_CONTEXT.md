# AI Context File for awesome-didaktika-programovani

This file is designed to help AI agents (Claude, Gemini, Copilot, etc.) understand the structure and content of this repository.

## Repository Overview
This repository contains a collection of educational programming projects and materials for the subject "Didactics of Programming" (KI/DPG). It includes examples in C#, Python, Alice 3, Scratch, and LOGO.

## Directory Structure & Content

### `/ChessConsole`
**Language:** C# (.NET 5.0)
**Description:** A chess application solution containing two projects.
- **`ChessConsole` (Console App):**
  - Entry point: `Program.cs`
  - Functionality: Displays a chess board in the console. Allows the user to input coordinates to place a piece and calculates legal moves for a Knight ("Jezdec").
- **`chessGUI` (Windows Forms App):**
  - Entry point: `Program.cs`, Main Form: `Form1.cs`
  - Functionality: A GUI representation of the chess board using a grid of Buttons. Clicking a button places a Knight and highlights legal moves.
- **`ChessBoardModel` (Class Library):**
  - Contains the core logic for the chess board (`Board.cs`) and cells (`Cell.cs`).

### `/python_skvrny`
**Language:** Python
**Description:** Image processing projects using OpenCV.
- **`main.py`:** Basic circle detection using Hough Transform on `circles.jpg`.
- **`detektor.py`:** More advanced detection intended for PCR plates (`tes.png`). It detects wells (circles), identifies their color using `webcolors` and `scipy.spatial.KDTree`, and prepares to map them to grid coordinates (A1-H12).
- **Dependencies:** `opencv-python`, `numpy`, `webcolors`, `scipy`.

### `/alice`
**Platform:** Alice 3
**Description:** 3D programming projects and resources.
- **Files:** `.a3p` (Project), `.a3w` (World), and media files (`.mp3`, `.mkv`).
- **`Alice_story.md`:** A script/screenplay for an animation involving Alice and a Bear becoming friends.

### `/scratch`
**Platform:** Scratch 3
**Description:** Block-based programming projects.
- **Files:** `.sb3` files.
- **Projects:**
  - `frogger.sb3`: A Frogger game clone.
  - `caesarova_sifra.sb3`: Implementation of Caesar cipher.
  - `akvarium.sb3`: Aquarium animation/simulation.
  - `basic_color_detection_kamera.sb3`: Color detection using camera.

### Root Directory Files
- **`koch-logo.md`:** Documentation and code examples for the LOGO language, focusing on fractals (Koch snowflake, Recursive Tree, Triangle/Square/Curly fractals).
- **`kresleni-prasatko.md`:** Code examples in Python (Turtle) and LOGO for drawing a pig.
- **`Programování LEGO Mindstorm.pptx`:** Presentation about LEGO Mindstorms.
- **`metody.pptx`:** Presentation about methods (likely teaching methodology).

## Key Technologies
- **C# / .NET 5.0** (WinForms, Console)
- **Python** (OpenCV, NumPy, Turtle, Scipy)
- **Alice 3**
- **Scratch 3**
- **LOGO**

## Purpose
The repository serves as a portfolio of solved tasks and presentation materials for teaching programming concepts to students.
