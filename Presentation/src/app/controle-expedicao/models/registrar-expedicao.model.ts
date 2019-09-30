import { SolicitarColeta } from 'src/app/controle-coleta-definicao-carga/models/solicitar-coleta.model';

export class RegistrarExpedicao {
    public constructor(
        public coleta?: SolicitarColeta,
        public data?: Date
    ) {}
}