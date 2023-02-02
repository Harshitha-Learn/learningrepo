// =========== main.bicep ===========

// Setting target scope
targetScope = 'subscription'

param location string = deployment().location

// Creating resource group
resource rg 'Microsoft.Resources/resourceGroups@2021-01-01' = {
  name: 'rg-contoso'
  location: location
}

// Deploying storage account using module
module stg './storage.bicep' = {
  name: 'storageDeployment'
  scope: rg    // Deployed in the scope of resource group we created above
  params: {
    storageAccountName: 'teststg73h'
    location: location
  }
}