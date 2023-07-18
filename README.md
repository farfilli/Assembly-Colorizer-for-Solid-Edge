# Assembly Colorizer for Solid Edge

From a request made during Realize Live 2023 the idea to create this program.
The needings are a fast way to assign a random FaceStyle color to the occurrences of an assembly.
The typical scenario is to use it just after importing an exchange file when all the occurrences have the same gray color.

Still a work in progress

<img src="Main Form.png">

Each FaceStyle Name containing one of the words inserted in the textbox (comma separated) will not be used

**Single FaceStyle SubAssembly:** With this option checked SubAssemblies will be treated as a single occurrence

**Same file same FaceStyle:** With this option checked all the occurrences of the same file will have the same FaceStyle color

**Fast Mode (Process in background):** With this option checked the assembly is closed and opened in background, processed, and reopened. This is very fast, recommended for large assemblies

Binary archives included for those who just want a pre-compiled file

Contributors are very welcome!

Francesco
