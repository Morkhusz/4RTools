# Copilot Instructions for 4RTools

## Project Overview
- 4RTools is an all-in-one tool for **Ragnarök Online** servers, providing features like Autopot, Skill Spammer, Macro Songs, Profile Management, and more.
- The project is open source under the MIT License and encourages community collaboration.

## Structure
- Main project files are in the `4RTools/` directory.
- Forms for each feature are in `4RTools/Forms/` (e.g., `AutopotForm.cs`, `MacroSongForm.cs`).
- Core logic and models are in `4RTools/Model/` (e.g., `Autopot.cs`, `Macro.cs`, `Profile.cs`).
- Utilities are in `4RTools/Utils/`.
- Resources (images, etc.) are in `4RTools/assets/` and `4RTools/Resources/`.

## Build & Run
- Open `4RTools.sln` in Visual Studio 2022 or later.
- Build and run directly from the IDE.

## Coding Guidelines
- Use C# best practices for WinForms applications.
- Place UI logic in `Forms/` and business logic in `Model/` or `Utils/`.
- Keep feature-specific code modular and separated by feature.
- Use descriptive names for forms and models (e.g., `AutopotForm`, `MacroSongForm`).
- All new features should have a corresponding Form and Model if needed.

## Contribution
- Follow the MIT License.
- Open issues or pull requests for bugs and new features.
- Keep code readable and well-documented.

## Resources
- Discord: https://discord.gg/HRWvG5ut
- Website: https://www.4rtools.com.br/

---

**Special instructions for GitHub Copilot:**
- When generating code, respect the project structure and file organization.
- For new features, create or update files in the appropriate `Forms/` and `Model/` subfolders.
- Use English for code and comments, unless otherwise specified.
- Always check for existing implementations before creating new ones.
- Ensure compatibility with Visual Studio 2022 and .NET Framework used in the project.
