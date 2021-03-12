function insert() {
	var num = $(this).text()
	$('.value').val($('.value').val() + num);
}
$(".num").click(insert)

function eql() {
	$('.value').val(eval($('.value').val()));
}
$(".equal").click(eql)

function c() {
	$('.value').val('');
}
$(".clear").click(c)
