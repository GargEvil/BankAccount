

export enum GenderType{
    Male = "Male",
    Female = "Female"
}
/*
export const GenderType2LabelMapping: Record<GenderType, string> ={
    [GenderType.Female]:"Female",
    [GenderType.Male]:"Male"
};
*/

export namespace GenderType {

    export function values(){
        return Object.keys(GenderType).filter((type) => isNaN(<any>type) && type !== 'values');
    }
}