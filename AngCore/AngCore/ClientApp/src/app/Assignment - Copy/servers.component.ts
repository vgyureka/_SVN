import { Component } from '@angular/core';
@Component({
  selector: 'app-servers', 
  templateUrl: './servers.component.html'
})
export class ServersComponent {
  serverCreationStatus = "server disaled";
  serverName = "test";

  OnCreateServer() {
    this.serverCreationStatus = "server enaled";
  }
}
