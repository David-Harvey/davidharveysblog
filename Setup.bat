dotnet new --install Microsoft.AspNetCore.SpaTemplates::*
dotnet restore 
npm install
npm install -g webpack
npm install Microsoft.EntityFrameworkCore.SqlServer
npm install Microsoft.EntityFrameworkCore.Tools
setx ASPNETCORE_ENVIRONMENT "Development"
webpack --config webpack.config.vendor.js