# EmguTest

Either copy this repository and go to step 5 or reproduce manually:
0. Create a Console Application
1. Add the following NuGet Packages:
 - Emgu.CV
 - Emgu.CV.runtime.windows
 - Emgu.CV.runtime.ubuntu.20.04-x64
2. Insert the code in the Program.cs
3. Publish your application as a self contained application:

`dotnet publish -c release -r ubuntu.16.04-x64`

4. Copy the project to ubuntu
5. In ubuntu CLI, navigate to the publish folder
6. Provide execute permissions:

`chmod 777 ./EmguTestUbuntu`

7. Execute application and see the error

`./EmguTestUbuntu`
