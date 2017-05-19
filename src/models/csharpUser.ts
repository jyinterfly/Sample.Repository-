import { ICsharpUser } from "../interfaces/user";



export interface IUserModel extends ICsharpUser {
  //custom methods for your model would be defined here
        GetList();
}

export class UserModel implements IUserModel
{   

    GetList(){

         var edge = require("edge")
         const method = 'GetList'
         const  dllPath  = '../sinopacosu/dist/CshartpDll/Simple.PresentLayer.dll';
         const  typeName = 'Simple.PresentLayer.UserEndpoint'
         
         var objDLL = edge.func({
            assemblyFile: dllPath,
            typeName: typeName,
            methodName: method
            });
            
        console.log(objDLL("test",true));
    }
}