import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WelcomingComponent } from './components/welcoming/welcoming.component';

const routes: Routes = [
  //// 1. الرابط الافتراضي (لما يفتح الموقع أول مرة)
  { path: '', component: WelcomingComponent },

  //// 2. رابط مباشر
  //{ path: 'employment', component: EmploymentComponent },

  //// 3. رابط مع متغير (مثلاً ID الموظف)
  //{ path: 'profile/:id', component: ProfileComponent },

  //// 4. الـ Wildcard (لأي رابط خطأ أو غير موجود)
  //{ path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [],
  imports: [
      RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})
export class EmploymentRoutingModule { }
