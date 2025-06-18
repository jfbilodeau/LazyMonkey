param appServiceName string

resource appService 'Microsoft.Web/sites@2022-03-01' = {
  name: appServiceName
  location: 'Canada East'
  properties: {
    serverFarmId: resourceId('Microsoft.Web/serverfarms', 'LazyMonkey-ASP')
    siteConfig: {
      linuxFxVersion: 'DOTNET|9.0'
      alwaysOn: true    
    }
  }
}
