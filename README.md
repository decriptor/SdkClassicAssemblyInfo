# Sdk vs Classic AssemblyInfo Test

This is a test project to see if I can have both sdk projects and classic projects take advantage of the centralized assembly info information set in the Director.Build.props file.

Sdk projects do this by default, but classic projects do not. So, I created GlobalAssemblyInfo.targets that can be imported into classic projects. That targets file will generate a GlobalAssemblyInfo.cs file in the $(IntermediateOutputPath) directory. Currently, you'd have to manually add a compile item to your classic project. In hindsight, this should probably be a .props file and include the
"<Compile Include="$(IntermediateOutputPath)GeneratedAssemblyInfo.cs" />"
line in it.

This way, I can have both projects use the same assembly information.
