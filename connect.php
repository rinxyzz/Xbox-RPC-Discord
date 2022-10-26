<?
  if (isset($_POST['id']) && is_numeric($_POST['id'])){
  $id = discord_real_escape_string($conn, $_POST['id']);

  if (isset($_GET['id']) && is_numeric($_GET['id'])){
 $id = discord_real_escape_string($conn, $_GET['id']);
?>