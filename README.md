# 🎓 KI/DPG - Didaktika programování

**Sbírka vypracovaných úloh a výukových materiálů**

Tento repozitář slouží jako portfolio projektů a materiálů vytvořených pro předmět **Didaktika programování (KI/DPG)**. Obsahuje ukázky kódu, aplikace a prezentace zaměřené na výuku programování v různých jazycích a prostředích.

---

## 📂 Obsah repozitáře

### 1. ♟️ Šachy (C# .NET)
Aplikace demonstrující logiku pohybu šachových figurek (konkrétně jezdce) v prostředí .NET 5.0.
- **Umístění:** `/ChessConsole`
- **Obsahuje:**
  - **Console App:** Textová verze šachovnice, výpočet legálních tahů.
  - **Windows Forms App (GUI):** Grafické rozhraní s interaktivní mřížkou tlačítek.
  - **ChessBoardModel:** Sdílená knihovna s logikou hry.
- **Technologie:** C#, .NET 5.0, WinForms.

### 2. 🐍 Detekce skvrn a obrazu (Python)
Skripty pro zpracování obrazu pomocí knihovny OpenCV.
- **Umístění:** `/python_skvrny`
- **Projekty:**
  - **Detekce kruhů:** Základní detekce tvarů pomocí Hough Transform (`main.py`).
  - **Analýza PCR destičky:** Pokročilejší skript (`detektor.py`) pro detekci jamek, určení jejich barvy a mapování souřadnic.
- **Technologie:** Python, OpenCV, NumPy, SciPy, Webcolors.

### 3. 👩‍💻 Alice 3
Projekty a materiály pro výuku v 3D prostředí Alice.
- **Umístění:** `/alice`
- **Obsah:**
  - Zdrojové soubory projektů (`.a3p`, `.a3w`).
  - Scénář animace "Alenka a Medvěd" (`Alice_story.md`).
  - Multimediální soubory (zvuky, video ukázka).

### 4. 🐱 Scratch 3
Sada projektů pro blokové programování ve Scratchi.
- **Umístění:** `/scratch`
- **Projekty:**
  - 🐸 **Frogger:** Klon klasické arkádové hry.
  - 🔐 **Caesarova šifra:** Implementace šifrovacího algoritmu.
  - 🐟 **Akvárium:** Animace.
  - 📷 **Detekce barev:** Využití kamery pro interakci.

### 5. 🐢 LOGO a Turtle Graphics
Výukové materiály pro želví grafiku a rekurzi.
- **Soubory:**
  - `koch-logo.md`: Kódy pro fraktály (Kochova vločka, rekurzivní stromy).
  - `kresleni-prasatko.md`: Ukázka kreslení obrázku v Python Turtle a LOGO.

### 6. 📊 Prezentace
- `Programování LEGO Mindstorm.pptx`: Úvod do robotiky s LEGO Mindstorms.
- `metody.pptx`: Metodické materiály.

---

## 🚀 Jak začít

### C# Projekty
Otevřete soubor `ChessConsole.sln` v **Visual Studio 2019/2022**.
- Pro spuštění GUI nastavte projekt `chessGUI` jako *Startup Project*.
- Pro spuštění konzole nastavte `ChessConsole`.

### Python Projekty
Nainstalujte potřebné závislosti:
```bash
pip install opencv-python numpy scipy webcolors
```
Spusťte skripty:
```bash
python python_skvrny/main.py
# nebo
python python_skvrny/detektor.py
```

### Ostatní
- **Scratch:** Soubory `.sb3` otevřete v online editoru [Scratch](https://scratch.mit.edu/) nebo v desktopové aplikaci.
- **Alice:** Vyžaduje instalaci prostředí [Alice 3](http://www.alice.org/).
- **LOGO:** Kódy lze vyzkoušet v online interpretech, např. [JSLogo](https://www.calormen.com/jslogo/).

---

## 🔗 Zdroje a inspirace
- [Python detekce skvrn (Medium)](https://medium.com/codex/well-and-color-detection-of-pcr-plate-using-python-and-opencv-edb0aaa0ef9d)
- [Šachy tutorial (YouTube)](https://www.youtube.com/playlist?list=PLhPyEFL5u-i0YDRW6FLMd1PavZp9RcYdF)
- [Alice tutorial (YouTube)](https://www.youtube.com/playlist?list=PLmpmyPywZ440OmMec0WWu6jqdqCXMd8Td)
- [Scratch Frogger tutorial](https://learnlearn.uk/scratch/scratch-frogger-game-tutorial/)

---
*Autor: Jakub Škrabánek*




