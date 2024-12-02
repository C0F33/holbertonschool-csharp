#!/bin/bash

PROJECT_NAME="1-new_project"

if [ -d "$PROJECT_NAME" ]; then
  echo "Directory '$PROJECT_NAME' already exists. Exiting."
  exit 1
fi

mkdir "$PROJECT_NAME"
cd "$PROJECT_NAME"

echo "Initializingn a new C# console project..."
dotnet new console

echo "Restoring packages for the project..."
dotnet restore

echo "Building the project..."
dotnet build

echo "C# project has been created, restored, and built successfully in '$PROJECT_NAME'."

echo "Project files:"
ls -l
