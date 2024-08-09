# Sdk vs Classic AssemblyInfo Test

This is a test project was to see if I can have both sdk projects and classic projects take advantage of the centralized assembly info information set in the Director.Build.props file.

Sdk projects does this by default, but classic projects do not. So, I created GlobalAssemblyInfo.cs and linked it to the classic project. This way, I can have both projects use the same assembly information.
