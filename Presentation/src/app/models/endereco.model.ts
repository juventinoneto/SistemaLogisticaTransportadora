export class Endereco {
    public constructor(
        public idEndereco?: number,
        public ruaAvenida?: string,
        public bairro?: string,
        public cep?: string,
        public numero?: number,
        public cidade?: string,
        public uf?: string,
        public complemento?: string,
    ) {}
}