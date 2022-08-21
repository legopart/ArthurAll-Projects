import React, {Component} from "react";
export class ItemsExtends extends Component {
    state = {
        page: 0
        , rows: [] //will set from the server
        , loading: false
        , selectionModel: []
    }
    constructor(props){
        super(props);
        this.prevSelectionModel = React.createRef(this.state.selectionModel);
    }
    componentDidMount= async() => {
        let active = true;
        this.setState({ loading: true });
        //const newRows = await loadServerRows(page, data);   //+sortBy
        if (!active) return;
        //this.props.state.setState({ data :newRows });
        this.setState({ loading: false });
/* */   ///setTimeout(() => this.props.state.setState({ checkedData: this.prevSelectionModel.current } ));
        return () => active = false;
      }     //React.useEffect( () => {}, [page, data]);
}