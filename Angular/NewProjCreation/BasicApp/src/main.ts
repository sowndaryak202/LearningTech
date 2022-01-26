import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { MasterpageModule } from './RetailApp/MasterPage/MasterPage.module';



platformBrowserDynamic().bootstrapModule(MasterpageModule)
  .catch(err => console.error(err));
