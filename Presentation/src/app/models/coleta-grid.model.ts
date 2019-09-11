import { Endereco } from "./endereco.model";
import { Cliente } from "./cliente.model";
import { Expedicao } from "./expedicao.model";

export class ColetaGrid {

    public constructor(
        idColeta?: number,
        cliente?: Cliente,
        parceiro?: Cliente,
        dataColeta?: Date,
        endereco?: Endereco,
        expedicao?: Expedicao,
        status?: string
    ) {}

}