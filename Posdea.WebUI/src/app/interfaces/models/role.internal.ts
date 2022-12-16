import { MenuOptionInternal } from "./menuOption.internal";

export interface RoleInternal {
  id : number;
  name  : string;
  status  : string;
  menuOptions : MenuOptionInternal[];
}