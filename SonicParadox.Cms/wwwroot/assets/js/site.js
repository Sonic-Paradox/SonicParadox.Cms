loopThroughElements = (elements, action) => {
    for (let i = 0; i < elements.length; ++i) {
        const element = elements[i];
        action(element);
    }
};

class StaffPopoutController {
    isOpen = false;
    element;
    binder;

    constructor(element) {
        this.element = element;
        this.binder = new GravyBinder(this, this.element);
        this.bindEvents();
    }

    toggleDialog = (openState) => {
        if (openState === undefined || openState === null)
            openState = !this.isOpen;
        this.isOpen = openState;
        this.binder.updateOutwardBindings();
    }

    bindEvents = () => {
        this.element.onclick = event => this.toggleDialog();
        loopThroughElements(this.element.getElementsByClassName('staff__biography'), el => el.onclick = event => event.stopPropagation());
    }
}

loopThroughElements(document.getElementsByClassName('staff'), element => element.staffController = new StaffPopoutController(element));