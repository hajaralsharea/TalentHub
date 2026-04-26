import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: 'employment', pathMatch: 'full' },
  {
    path: 'employment',
    loadChildren: () => import('../../../../../Modules/Employment/Employment.UI/ClientUIModule/lib/employment.module').then(m => m.EmploymentModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
