	<?php

	$print_name='';
if(isset($_POST['submit']) ){
	if(!empty($_POST['name'])){
		echo htmlspecialchars( $_POST['name'] );
		$print_name=$_POST['name'];
	}
		else{echo 'name is empty';}
	echo '<hr>';
}

	?>

<!DOCTYPE html />
<html lang="en,he">
    <head>
        <title>PHP Tutrial index</title>
    </head>
    <body>
        <h1>PHP Form</h1>
        <hr />

<form action="form.php" method="POST">
<label>name:</label>
<input type="text" name="name" value="<?php echo $print_name; ?>">
<input type="submit" name="submit">
</form>

    </body>
</html>