import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { AppRoutingModule } from "../app-routing.module";
import { MainLayoutComponent } from "./main-layout/main-layout.component";
import { AuthLayoutComponent } from "./auth-layout/auth-layout.component";




@NgModule({
    imports: [CommonModule, AppRoutingModule],
    declarations: [MainLayoutComponent, AuthLayoutComponent],
    exports: [MainLayoutComponent, AuthLayoutComponent]
  })
  export class LayoutModule {}