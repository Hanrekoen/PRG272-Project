# Superhero Management System

A Windows Forms desktop application in C# for managing superhero records, stored in a plain text file. Built for PRG272 to demonstrate **multi-layered architecture**.

---

## Architecture

The point of this project is the separation between layers — each has one job and talks only to the layer below it:

```
PresentationLayer/   Form1, FormatHandler, Program   - the UI and display formatting
BusinessLayer/       HeroManager, SuperHero          - rules and the domain model
DataLayer/           FileHandler                     - reading and writing the file
Files/               superheroes.txt                 - storage
```

The UI never touches the file directly, and the data layer knows nothing about the UI. Swapping text-file storage for a database would mean changing `DataLayer` only.

---

## Features

- Add a new superhero record
- Edit an existing record
- View all records in the form
- Records persist to `superheroes.txt` between runs

---

## Running it

Requires Visual Studio and .NET Framework.

1. Open `Project272/Project272.sln`
2. Build and run
3. `Files/superheroes.txt` is created and updated as you add records

---

## Built with

C# · Windows Forms · .NET Framework · file-based persistence

---

## Author

**Hanré Koen** — [@Hanrekoen](https://github.com/Hanrekoen)
