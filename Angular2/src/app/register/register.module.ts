import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RegisterComponent } from './register.component';
import { FormsModule, ReactiveFormsModule, FormGroup } from '@angular/forms';
import {CheckboxModule} from 'primeng/primeng';
import { RegisterService } from './register.service';
import {SelectButtonModule} from 'primeng/primeng';
import { CampoControlErroComponent } from './campo-control-erro/campo-control-erro.component';
import {GrowlModule} from 'primeng/primeng';

@NgModule({
  declarations: [
    RegisterComponent,
    CampoControlErroComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    CheckboxModule,
    SelectButtonModule,
    ReactiveFormsModule,
    GrowlModule
  ],
  providers: [],
  bootstrap: [RegisterComponent]
})

export class AppModuleRegister { }