import { Endereco } from 'src/app/models/endereco.model';

export class SolicitarColetaCliente {
    public constructor(
        public nome?: string,
        public documento?: string,
        public endereco?: Endereco
    ) {}
}