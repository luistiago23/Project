import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { RegisterComponent } from '../register/register.component';
import { AuthGuard } from '../guards/auth-guard';
import { ListComponent } from '../list/list-component';

@NgModule({
  imports: [
    RouterModule.forRoot([
      { path: '', redirectTo: 'register', pathMatch: 'full' },
      { path: 'register', component: RegisterComponent, pathMatch: 'full' },
      { path: 'register/:id', component: RegisterComponent, pathMatch: 'full' },
      { path: 'list', component: ListComponent, pathMatch: 'full' }
    ])
  ],
  declarations: [],
  exports: [ RouterModule]
})
export class AppRoutingModule { }
