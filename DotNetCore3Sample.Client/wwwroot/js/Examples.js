//Example1.Open / Close Bootstrap Modal from C#
async function CloseModalById(idname) {
    console.debug("CloseModalById() Called. idname[" + idname + "]");
    $(idname).modal("hide");
}

async function ShowModalById(idname) {
    console.debug("CloseModalById() Called. idname[" + idname + "]");
    $(idname).modal("show");
}
