import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'StudentStore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44310',
    redirectUri: baseUrl,
    clientId: 'StudentStore_App',
    responseType: 'code',
    scope: 'offline_access StudentStore',
  },
  apis: {
    default: {
      url: 'https://localhost:44310',
      rootNamespace: 'Acme.StudentStore',
    },
  },
} as Environment;
