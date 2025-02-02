
function ScrollTo(sectionId) {
    console.log('ScrollTo:' + sectionId);
    document.getElementById(sectionId)?.scrollIntoView({ behavior: 'smooth' });
}