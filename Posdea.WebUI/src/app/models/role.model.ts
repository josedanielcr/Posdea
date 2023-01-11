import { MenuOption } from "./menuOption.model";

export class Role {
  public id! : number;
  public name!  : string;
  public status!  : string;
  public menuOptions! : MenuOption[];

  constructor(){}
}