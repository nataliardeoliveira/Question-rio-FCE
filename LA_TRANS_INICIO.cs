// ************************************************************************
// *  Nome Transicao.......: LA_TRANS_INICIO
// *  Documental...........: Licenciamento Ambiental
// *  Processo.............: Licenciamento Ambiental
// *  Atividade origem.....: Inicio
// *  Atividade destino....: Questionário FCE
// ************************************************************************

protocolo = DateTime.Now.ToString("yyyy.MM.dd.HHmmss") + "." + doc.DocVersao.DocumentoId.ToString();
criadorNome = doc.CriadorNome();
criadorId = doc.UsuarioId.ToString();

doc.Campo(7, protocolo);
doc.Campo(3, criadorNome);
doc.Campo(9, criadorId);