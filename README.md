#### setup
nuget restore
nuget install StoryBoardFlow -Source ~/DEV/my_projects/nuget_repo/ -OutputDirectory packages

#### Build project:
msbuild && cd Spaceship.Linux/ && msbuild && cd ..

#### Run project:
mono Spaceship.Linux/bin/DesktopGL/Any\ CPU/Debug/Spaceship.Linux.Desktop.exe

#### Build and Run:
msbuild && cd Spaceship.Linux/ && msbuild && cd .. && mono Spaceship.Linux/bin/DesktopGL/Any\ CPU/Debug/Spaceship.Linux.Desktop.exe
