import { NgModule } from '@angular/core';
import { ListComponent } from './list-component';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { ListService } from './list.service';

@NgModule({
    declarations: [
        ListComponent,
    ],
    imports: [
      BrowserModule,
      FormsModule,
    ],
    providers: [],
    bootstrap: [ListComponent]
  })

export class ListModule {

}