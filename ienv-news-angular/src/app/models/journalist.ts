export interface Journalist {
    ID: number;
    Nom: string;
    Prenom: string;
    Statu: string;
    Tele: number;
    Image: string;
    Email: string;   
    articles:
        {
            Img :string;
            Titre:string;
            Description:string;
            Journaliste:string;
            Date :Date;
            Body:string;
            ID:number;
            JournalistesID:number;
        }
    
  

}
