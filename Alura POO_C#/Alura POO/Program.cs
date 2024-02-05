//Banda Brocasito = new Banda("Brocasito");

//Album albumDoBrocasito = new Album("Matrix");

//Musica musica1 = new Musica(Brocasito, "1..2..3(intro)")
//{
//    Duracao = 154,
//    Disponivel = true,
//};
//Musica musica2 = new Musica(Brocasito, "O Escolhido")
//{
//    Duracao = 227,
//    Disponivel = false,
//};


//albumDoBrocasito.AdicionarMusica(musica1);
//albumDoBrocasito.AdicionarMusica(musica2);
//Brocasito.AdicionarAlbum(albumDoBrocasito);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//Brocasito.ExibirDiscografia();
//albumDoBrocasito.ExibirMusicasDoAlbum();

Episodio ep1 = new(2, "Tecnicas de Facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");


Episodio ep2 = new(1, "Tecnicas de aprendizado", 67);
ep2.AdicionarConvidados("fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast Especial", "Giovanne");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();



