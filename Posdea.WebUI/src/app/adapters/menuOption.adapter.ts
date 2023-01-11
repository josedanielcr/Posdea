import { MenuOptionInternal } from "../interfaces/models/menuOption.internal";
import { MenuOption } from "../models/menuOption.model";

export const adaptMenuOption = (menuOptionInternal : MenuOptionInternal) : MenuOption => {
  let menuOption = new MenuOption();
  menuOption.name = menuOptionInternal.name;
  menuOption.icon = menuOptionInternal.icon;
  menuOption.roleId = menuOptionInternal.roleId;
  menuOption.route = menuOptionInternal.route;
  menuOption.status = menuOptionInternal.status;
  return menuOption; 
}

export const adaptMenuOptions = (internalMenuOptions : MenuOptionInternal[]) : MenuOption[] => {
  let menuOptions : MenuOption[] = [];
  internalMenuOptions.forEach(( internalMenuOption : MenuOptionInternal) => {
    menuOptions.push(adaptMenuOption(internalMenuOption));
  } )
  return menuOptions;
}