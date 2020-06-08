import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { TeacherComponent } from './teacher/teacher.component';
import { UserComponent } from './user/user.component';
import { StudentComponent } from './student/student.component';
import { MarkComponent } from './mark/mark.component';
import { PresenceComponent } from './presence/presence.component';


const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'teacher', component: TeacherComponent },
  { path: 'user', component: UserComponent },
  { path: 'student', component: StudentComponent ,children:[  { path: 'mark', component: MarkComponent },{path:'presence',component:PresenceComponent}] },
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],

  exports: [RouterModule]
})
export class AppRoutingModule { }
