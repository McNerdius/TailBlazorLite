dotnet build # [wonky things](https://github.com/dotnet/aspnetcore/issues/34500) can happen without explicit pre-build
start "dotnet" -ArgumentList "watch run" # -nonewwindow
npm run watch