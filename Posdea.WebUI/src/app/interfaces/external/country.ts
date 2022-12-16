export interface Country {
  name:         Name;
  flags:        CoatOfArms;
  postalCode:   PostalCode;
  ccn3:         string;
}

export interface Name {
  common:     string;
  official:   string;
}

export interface CoatOfArms {
  png: string;
  svg: string;
}

export interface PostalCode {
  format: string;
  regex:  string;
}