import { Endereco } from "./endereco.model";

export class Cliente {
    public constructor(
        public idCliente?: number,
        public nome?: string,
        public documento?: string,
        public endereco?: Endereco
    ) {}
}