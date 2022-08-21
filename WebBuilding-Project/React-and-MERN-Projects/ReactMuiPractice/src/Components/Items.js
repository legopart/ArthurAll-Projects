import React from "react";
import { useParams, useNavigate } from 'react-router-dom';
//import * as Mui from '@mui/material';
import { DataGrid } from '@mui/x-data-grid';
//import { createStyles, makeStyles } from "@material-ui/core/styles";
//import { useDemoData } from "@mui/x-data-grid-generator";
import {ItemsExtends} from './ItemsExtends';

/* *
function loadServerRows(page, data) {
  return new Promise((resolve) => { setTimeout(() => {
      resolve(data.rows.slice(page * 5, (page + 1) * 5));
    }, Math.random() * 500 + 100); // simulate network latency
  }); }
/* */

export function ItemsFun(props) { return(<> <Items {...props}  params={useParams()} navigation={useNavigate()}/> </>); }

export class Items extends ItemsExtends {
    render() { 
        const {data, checkedData, setState} = this.props?.state;
        const {/*value,*/ navigation} = this.props?.params;
        
        const onClickNavigate = (rowCell) => navigation('/items/'+rowCell.id.toString() ) ;
        const columns = [
          { field: "id", headerName: "ID", width: 20, description:"Product id" }
          , { field: "image", headerName: "Image", width: 100, sortable: false, description:"Product image"
            , renderCell: (rowCell) => (
              <div onClick={(e) => {onClickNavigate(rowCell);}}> <img alt={'image '+rowCell.id} style={{width: '60px', height:'auto'}} src={rowCell.value} /> </div> ) 
            }
          , { field: "title", headerName: "Product Name", flex: 1, align: "left", description:"Item name"
            , renderCell: (rowCell) => (
                <div onClick={(p, e) => {onClickNavigate(rowCell);}}  style={{ color: "blue", fontSize: 18, width: "100%", textAlign: "left" }}> {rowCell.value} </div>) 
            //, valueGetter: (params) => { return `${params.getValue(params.id, "image") || ""} ${ params.getValue(params.id, "title") || "" }`;}/
            }
          , { field: "price", headerName: "Price", type: "number", width: 90, align: "center" }
        ];

        return (<>
          <div style={{ height: 400, width: "100%" }}>
            <DataGrid rows={ data } columns={columns}
              pagination rowsPerPageOptions={[5, 10, 20]} loading={this.state.loading}
  /*!!! */   onPageChange={ newPage => { this.prevSelectionModel.current = this.state.selectionModel; this.setState({ page: newPage }); }}  //!?
              onSelectionModelChange={ newSM => setState( {checkedData: newSM} ) }
              selectionModel={ checkedData }
              checkboxSelection //disableSelectionOnClick 
            />
          </div>
          {/* !value ? <>Items<br />{data?.map( (x, i) => inputCheckBox('a', i, () => x.title.toString()) )}</>
                    : <>Item {value}<br /> {inputCheckBox('b', value, () => data[value]?.title)} </>  */}
        </>);
    }
}