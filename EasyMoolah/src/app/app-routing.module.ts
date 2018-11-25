import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { ContentComponent } from './content/content.component';
import { HomeComponent } from './content/home/home.component';
import { AboutComponent } from './content/about/about.component';
import { ContactComponent } from './content/contact/contact.component';
import { BorrowerApplicationComponent } from './content/borrower-application/borrower-application.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' }, //'' is apart of every path
  { path: 'home', component: HomeComponent},
  { path: 'about', component: AboutComponent },
  { path: 'contact', component: ContactComponent }
  // , children: [
  //     { path: 'home', component: HomeComponent },
  //     { path: 'about', component: AboutComponent }
  //   ]
  // }
  // { path: 'recipes', component: ContentComponent, children: [
  // { path: '', component: ContentComponent}[
  // { path: '', component: HomeComponent}
  // ] }
  //   { path: 'new', component: RecipeEditComponent },
  //   { path: ':id', component: RecipeDetailComponent },
  //   { path: ':id/edit', component: RecipeEditComponent },
  // ] },
  // { path: 'shopping-list', component: ShoppingListComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

}
