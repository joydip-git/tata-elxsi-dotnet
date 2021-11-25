import { enableProdMode, PlatformRef } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';

if (environment.production) {
  enableProdMode();
}

const platform: PlatformRef = platformBrowserDynamic();
console.log(platform)
platform.bootstrapModule(AppModule)
  .then(m => console.log(m))
  .catch(err => console.error(err));