import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {

  serverID:number=1001;
  serverStatus:string='Offline';

  addNewServer:boolean=false;

  serverCreated:string='';

  serversList = ['SQL','Oracle'];

serverName:string='';
// onServerNameEntry(event:Event)
// {
//   console.log(event);
//   //this.serverName=(<HTMLInputElement>event.target).value;
// }

constructor()
{
  setTimeout(()=>{
  this.addNewServer=true;
},5000);
}

onServerCreation()
{
  this.serverCreated="Created";
  this.serversList.push(this.serverName);
}



getServerId()
{
  return this.serverID;
}

getServerStatus()
{
  return this.serverStatus;
}

}
