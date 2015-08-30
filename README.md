# MonoAspnetMvcRazor
ASP.NET MVC 5 with Razor using MySQL (EntityFramework) able to run with Linux

USAGE:
  (suggesting you are running Ubuntu)
  1. run command "sudo apt-get update && sudo apt-get install mono-complete"
  2. download NuGet.exe from "https://nuget.org/nuget.exe"
  3. clone this repo
  4. cd into *project* dir in solution, run "NuGet.exe restore -OutputDirectory ../packages" (case sensitive)
  5. replace mysql connectionString in Web.config to your own
  6. wait for command finish
  7. run command "xsp4"
  8. open browser and navigate to "http://localhost:8080/"
