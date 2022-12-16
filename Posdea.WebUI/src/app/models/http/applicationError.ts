export class ApplicationError {
  public status : number;
  public type : string;
  public title : string;
  public traceId : string;
  constructor(status : number, type : string, title : string, traceId : string){
    this.status = status;
    this.type = type;
    this.title = title;
    this.traceId = traceId;
  }
}