dotnet build # wonky things can happen without explicit pre-build
start "dotnet" -ArgumentList "watch run" # -nonewwindow
npm run watch