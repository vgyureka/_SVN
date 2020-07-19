import { Component } from '@angular/core';
@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styles: [`
   .online
{
color : white;
}
`]
})
export class ServersComponent {
  serverCreationStatus = "server disaled";
  serverName = "test";
  ServerCreated = false;
  status: string = 'offline';
  toggle = false;
  servers = ['server1','server2'];

  OnCreateServer() {
    this.serverCreationStatus = "server enaled";
    this.ServerCreated = true;
    //this.status = 'online';
    this.toggle = (this.toggle == true) ? false : (this.toggle == false ? true : true);
    this.status = this.toggle ? 'online' : 'offline';
    this.servers.push(this.serverName);
  }
  getColor() {
    return this.toggle ? 'green' : 'red';
  }
}
