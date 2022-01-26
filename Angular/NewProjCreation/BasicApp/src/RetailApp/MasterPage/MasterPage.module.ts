import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { MasterpageComponent } from './MasterPage.component';

@NgModule({
  declarations: [
    MasterpageComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [MasterpageComponent]
})
export class MasterpageModule { }
