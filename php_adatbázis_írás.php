<?php
		$kapcs=mysql_connect('localhost','root','');
		mysql_select_db('hird',$kapcs);
		if (isset($_POST['ok']))
		{
			if ($_POST['password']==$_POST['password2'])
			{
				if (!$_POST['felhnev']=="")
				{
					$beir=("insert into reg values('$_POST[felhnev]','$_POST[nev]','$_POST[password]','$_POST[email]')");
					mysql_query($beir,$kapcs);
					
				} else echo "A felhasználónév kitöltése kötelező!";
			} else echo "A két jelszónak egyeznie kell!";
		}
?>
