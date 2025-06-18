param appServiceName string

resource appService 'Microsoft.Web/sites@2022-03-01' = {
  name: appServiceName
  location: 'Canada East'
  properties: {
    serverFarmId: resourceId('Microsoft.Web/serverfarms', 'LazyMonkey-ASP')
    siteConfig: {
      appSettings: [
        {
          name: 'WEBSITE_STACK'
          value: 'ASP.NET'
        }
        {
          name: 'WEBSITE_ASPNET_VERSION'
          value: '9.0'
        }
      ]
    }
  }
}
